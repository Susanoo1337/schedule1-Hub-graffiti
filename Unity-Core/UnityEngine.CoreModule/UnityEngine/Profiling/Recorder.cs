using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

namespace UnityEngine.Profiling
{
	// Token: 0x0200017F RID: 383
	public sealed class Recorder : Object
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x000797B4 File Offset: 0x000779B4
		// Note: this type is marked as 'beforefieldinit'.
		static Recorder()
		{
			Il2CppClassPointerStore<Recorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", "Recorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recorder>.NativeClassPtr);
			Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_RecorderDefaultOptions");
			Recorder.NativeFieldInfoPtr_s_InvalidRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "s_InvalidRecorder");
			Recorder.NativeFieldInfoPtr_m_RecorderCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderCPU");
			Recorder.NativeFieldInfoPtr_m_RecorderGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recorder>.NativeClassPtr, "m_RecorderGPU");
			Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666455);
			Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666456);
			Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666457);
			Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666458);
			Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666459);
			Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666460);
			Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666461);
			Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666462);
			Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666463);
			Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recorder>.NativeClassPtr, 100666464);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000798FC File Offset: 0x00077AFC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00079938 File Offset: 0x00077B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282328, XrefRangeEnd = 1282333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recorder>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00079980 File Offset: 0x00077B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282333, XrefRangeEnd = 1282338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x000799B4 File Offset: 0x00077BB4
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x000799F0 File Offset: 0x00077BF0
		public unsafe bool enabled
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1282339, RefRangeEnd = 1282345, XrefRangeStart = 1282338, XrefRangeEnd = 1282339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1282351, RefRangeEnd = 1282357, XrefRangeStart = 1282345, XrefRangeEnd = 1282351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00079A30 File Offset: 0x00077C30
		public unsafe long elapsedNanoseconds
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282359, RefRangeEnd = 1282361, XrefRangeStart = 1282357, XrefRangeEnd = 1282359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x00079A6C File Offset: 0x00077C6C
		public unsafe long gpuElapsedNanoseconds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282363, RefRangeEnd = 1282364, XrefRangeStart = 1282361, XrefRangeEnd = 1282363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00079AA8 File Offset: 0x00077CA8
		public unsafe int sampleBlockCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282367, RefRangeEnd = 1282369, XrefRangeStart = 1282364, XrefRangeEnd = 1282367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00079AE4 File Offset: 0x00077CE4
		public unsafe int gpuSampleBlockCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1282372, RefRangeEnd = 1282373, XrefRangeStart = 1282369, XrefRangeEnd = 1282372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00079B20 File Offset: 0x00077D20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1282351, RefRangeEnd = 1282357, XrefRangeStart = 1282351, XrefRangeEnd = 1282357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recorder.NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0000DF74 File Offset: 0x0000C174
		public Recorder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00079B60 File Offset: 0x00077D60
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0000DF7D File Offset: 0x0000C17D
		public unsafe static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions
		{
			get
			{
				Unity.Profiling.ProfilerRecorderOptions result;
				IL2CPP.il2cpp_field_static_get_value(Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Recorder.NativeFieldInfoPtr_s_RecorderDefaultOptions, (void*)(&value));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00079B7C File Offset: 0x00077D7C
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0000DF8B File Offset: 0x0000C18B
		public unsafe static Recorder s_InvalidRecorder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recorder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Recorder.NativeFieldInfoPtr_s_InvalidRecorder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00079BA4 File Offset: 0x00077DA4
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0000DF9D File Offset: 0x0000C19D
		public unsafe Unity.Profiling.ProfilerRecorder m_RecorderCPU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderCPU)) = value;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00079BCC File Offset: 0x00077DCC
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public unsafe Unity.Profiling.ProfilerRecorder m_RecorderGPU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recorder.NativeFieldInfoPtr_m_RecorderGPU)) = value;
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00079BF4 File Offset: 0x00077DF4
		public static Recorder Get(string samplerName)
		{
			Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle = Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle.Get(Unity.Profiling.ProfilerCategory.Any, samplerName);
			bool flag = !handle.Valid;
			Recorder result;
			if (flag)
			{
				result = Recorder.s_InvalidRecorder;
			}
			else
			{
				result = new Recorder(handle);
			}
			return result;
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0000DFD3 File Offset: 0x0000C1D3
		public bool isValid
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public void FilterToCurrentThread()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0000DFED File Offset: 0x0000C1ED
		public void CollectFromAllThreads()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_s_RecorderDefaultOptions;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_s_InvalidRecorder;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeFieldInfoPtr_m_RecorderCPU;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_m_RecorderGPU;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProfilerRecorderHandle_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_get_elapsedNanoseconds_Public_get_Int64_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuElapsedNanoseconds_Public_get_Int64_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_get_sampleBlockCount_Public_get_Int32_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_get_gpuSampleBlockCount_Public_get_Int32_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Private_Void_Boolean_0;
	}
}
