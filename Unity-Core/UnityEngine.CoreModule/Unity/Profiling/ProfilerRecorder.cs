using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;

namespace Unity.Profiling
{
	// Token: 0x02000020 RID: 32
	[StructLayout(2)]
	public struct ProfilerRecorder
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0001A9D8 File Offset: 0x00018BD8
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorder()
		{
			Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr);
			ProfilerRecorder.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "handle");
			ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, "SharedRecorder");
			ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663380);
			ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663381);
			ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663382);
			ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663383);
			ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663384);
			ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663385);
			ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663386);
			ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663387);
			ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663388);
			ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663389);
			ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663390);
			ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663391);
			ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663392);
			ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663393);
			ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663394);
			ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663395);
			ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663396);
			ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663397);
			ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663398);
			ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663399);
			ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663400);
			ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663401);
			ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663402);
			ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663403);
			ProfilerRecorder.GetValueUnitType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueUnitType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueUnitType_Injected");
			ProfilerRecorder.GetValueDataType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueDataType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueDataType_Injected");
			ProfilerRecorder.GetCurrentValue_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValue_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValue_Injected");
			ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValueAsDouble_Injected");
			ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetLastValueAsDouble_Injected");
			ProfilerRecorder.GetWrapped_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetWrapped_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetWrapped_Injected");
			ProfilerRecorder.CopyTo_List_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_List_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_List_Injected");
			ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_Pointer_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_Pointer_Injected");
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001AC88 File Offset: 0x00018E88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225209, RefRangeEnd = 1225213, XrefRangeStart = 1225207, XrefRangeEnd = 1225209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity = 1, ProfilerRecorderOptions options = ProfilerRecorderOptions.Default)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref statHandle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		public unsafe bool Valid
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1225213, RefRangeEnd = 1225221, XrefRangeStart = 1225213, XrefRangeEnd = 1225213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001AD08 File Offset: 0x00018F08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225223, RefRangeEnd = 1225227, XrefRangeStart = 1225221, XrefRangeEnd = 1225223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0001AD30 File Offset: 0x00018F30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1225229, RefRangeEnd = 1225233, XrefRangeStart = 1225227, XrefRangeEnd = 1225229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0001AD58 File Offset: 0x00018F58
		public unsafe long LastValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1225235, RefRangeEnd = 1225237, XrefRangeStart = 1225233, XrefRangeEnd = 1225235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0001AD88 File Offset: 0x00018F88
		public unsafe int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1225239, RefRangeEnd = 1225241, XrefRangeStart = 1225237, XrefRangeEnd = 1225239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		public unsafe bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1225243, RefRangeEnd = 1225244, XrefRangeStart = 1225241, XrefRangeEnd = 1225243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001ADE8 File Offset: 0x00018FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225246, RefRangeEnd = 1225248, XrefRangeStart = 1225244, XrefRangeEnd = 1225246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorderSample GetSample(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0001AE28 File Offset: 0x00019028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225248, XrefRangeEnd = 1225250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref statHandle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0001AE84 File Offset: 0x00019084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225250, XrefRangeEnd = 1225252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Control(ProfilerRecorder handle, ProfilerRecorder.ControlOptions options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001AEC4 File Offset: 0x000190C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225252, XrefRangeEnd = 1225254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLastValue(ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001AF04 File Offset: 0x00019104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225254, XrefRangeEnd = 1225256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCount(ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001AF50 File Offset: 0x00019150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225256, XrefRangeEnd = 1225258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetValid(ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0001AF90 File Offset: 0x00019190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225258, XrefRangeEnd = 1225260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRunning(ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001AFD0 File Offset: 0x000191D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225260, XrefRangeEnd = 1225262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0001B01C File Offset: 0x0001921C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225264, RefRangeEnd = 1225266, XrefRangeStart = 1225262, XrefRangeEnd = 1225264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001B044 File Offset: 0x00019244
		[CallerCount(0)]
		public unsafe void CheckInitializedAndThrow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001B06C File Offset: 0x0001926C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225266, XrefRangeEnd = 1225268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, ProfilerRecorderOptions options, out ProfilerRecorder ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &statHandle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSampleCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001B0C8 File Offset: 0x000192C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225268, XrefRangeEnd = 1225270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Control_Injected(ref ProfilerRecorder handle, ProfilerRecorder.ControlOptions options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0001B108 File Offset: 0x00019308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225270, XrefRangeEnd = 1225272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLastValue_Injected(ref ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0001B148 File Offset: 0x00019348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225272, XrefRangeEnd = 1225274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCount_Injected(ref ProfilerRecorder handle, ProfilerRecorder.CountOptions countOptions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001B194 File Offset: 0x00019394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225274, XrefRangeEnd = 1225276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetValid_Injected(ref ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001B1D4 File Offset: 0x000193D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225276, XrefRangeEnd = 1225278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetRunning_Injected(ref ProfilerRecorder handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001B214 File Offset: 0x00019414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225278, XrefRangeEnd = 1225280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSampleInternal_Injected(ref ProfilerRecorder handle, int index, out ProfilerRecorderSample ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000266E File Offset: 0x0000086E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0001B264 File Offset: 0x00019464
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002680 File Offset: 0x00000880
		public unsafe static ProfilerRecorderOptions SharedRecorder
		{
			get
			{
				ProfilerRecorderOptions result;
				IL2CPP.il2cpp_field_static_get_value(ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProfilerRecorder.NativeFieldInfoPtr_SharedRecorder, (void*)(&value));
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001B280 File Offset: 0x00019480
		public unsafe static ProfilerRecorder StartNew(ProfilerCategory category, string statName, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
		{
			char* ptr = statName;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return new ProfilerRecorder(category, ptr, statName.Length, capacity, options | ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001B2B4 File Offset: 0x000194B4
		public static ProfilerRecorder StartNew(ProfilerMarker marker, [Optional] int capacity, [Optional] ProfilerRecorderOptions options)
		{
			return new ProfilerRecorder(marker, capacity, options | ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0001B2D0 File Offset: 0x000194D0
		public static ProfilerRecorder StartNew()
		{
			return ProfilerRecorder.Create(default(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle), 0, ProfilerRecorderOptions.StartImmediately);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0001B2F4 File Offset: 0x000194F4
		public Unity.Profiling.LowLevel.ProfilerMarkerDataType DataType
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetValueDataType(this);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0001B318 File Offset: 0x00019518
		public ProfilerMarkerDataUnit UnitType
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetValueUnitType(this);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000268E File Offset: 0x0000088E
		public void Reset()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.Reset);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001B33C File Offset: 0x0001953C
		public long CurrentValue
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCurrentValue(this);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0001B360 File Offset: 0x00019560
		public double CurrentValueAsDouble
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCurrentValueAsDouble(this);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0001B384 File Offset: 0x00019584
		public double LastValueAsDouble
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetLastValueAsDouble(this);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0001B3A8 File Offset: 0x000195A8
		public int Capacity
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetCount(this, ProfilerRecorder.CountOptions.MaxCount);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0001B3D0 File Offset: 0x000195D0
		public bool WrappedAround
		{
			get
			{
				this.CheckInitializedAndThrow();
				return ProfilerRecorder.GetWrapped(this);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0001B3F4 File Offset: 0x000195F4
		public void CopyTo(List<ProfilerRecorderSample> outSamples, [Optional] bool reset)
		{
			bool flag = outSamples == null;
			if (flag)
			{
				throw new ArgumentNullException("outSamples");
			}
			this.CheckInitializedAndThrow();
			ProfilerRecorder.CopyTo_List(this, outSamples, reset);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001B42C File Offset: 0x0001962C
		public unsafe int CopyTo(ProfilerRecorderSample* dest, int destSize, [Optional] bool reset)
		{
			this.CheckInitializedWithParamsAndThrow(dest);
			return ProfilerRecorder.CopyTo_Pointer(this, dest, destSize, reset);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000026A5 File Offset: 0x000008A5
		public Il2CppStructArray<ProfilerRecorderSample> ToArray()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000026B2 File Offset: 0x000008B2
		public void FilterToCurrentThread()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetFilterToCurrentThread);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000026C9 File Offset: 0x000008C9
		public void CollectFromAllThreads()
		{
			this.CheckInitializedAndThrow();
			ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetToCollectFromAllThreads);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000026E0 File Offset: 0x000008E0
		public static ProfilerMarkerDataUnit GetValueUnitType(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueUnitType_Injected(ref handle);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000026E9 File Offset: 0x000008E9
		public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueDataType_Injected(ref handle);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000026F2 File Offset: 0x000008F2
		public static long GetCurrentValue(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValue_Injected(ref handle);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000026FB File Offset: 0x000008FB
		public static double GetCurrentValueAsDouble(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValueAsDouble_Injected(ref handle);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002704 File Offset: 0x00000904
		public static double GetLastValueAsDouble(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetLastValueAsDouble_Injected(ref handle);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000270D File Offset: 0x0000090D
		public static bool GetWrapped(ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetWrapped_Injected(ref handle);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002716 File Offset: 0x00000916
		public static void CopyTo_List(ProfilerRecorder handle, List<ProfilerRecorderSample> outSamples, bool reset)
		{
			ProfilerRecorder.CopyTo_List_Injected(ref handle, outSamples, reset);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002721 File Offset: 0x00000921
		public unsafe static int CopyTo_Pointer(ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
		{
			return ProfilerRecorder.CopyTo_Pointer_Injected(ref handle, outSamples, outSamplesSize, reset);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001B454 File Offset: 0x00019654
		public unsafe void CheckInitializedWithParamsAndThrow(ProfilerRecorderSample* dest)
		{
			bool flag = this.handle == 0UL;
			if (flag)
			{
				throw new InvalidOperationException("ProfilerRecorder object is not initialized or has been disposed.");
			}
			bool flag2 = dest == null;
			if (flag2)
			{
				throw new ArgumentNullException("dest");
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000272D File Offset: 0x0000092D
		public static ProfilerMarkerDataUnit GetValueUnitType_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueUnitType_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000273A File Offset: 0x0000093A
		public static Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetValueDataType_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002747 File Offset: 0x00000947
		public static long GetCurrentValue_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValue_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002754 File Offset: 0x00000954
		public static double GetCurrentValueAsDouble_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField(ref handle);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002761 File Offset: 0x00000961
		public static double GetLastValueAsDouble_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField(ref handle);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000276E File Offset: 0x0000096E
		public static bool GetWrapped_Injected(ref ProfilerRecorder handle)
		{
			return ProfilerRecorder.GetWrapped_InjectedDelegateField(ref handle);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000277B File Offset: 0x0000097B
		public static void CopyTo_List_Injected(ref ProfilerRecorder handle, List<ProfilerRecorderSample> outSamples, bool reset)
		{
			ProfilerRecorder.CopyTo_List_InjectedDelegateField(ref handle, IL2CPP.Il2CppObjectBaseToPtr(outSamples), reset);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000278F File Offset: 0x0000098F
		public unsafe static int CopyTo_Pointer_Injected(ref ProfilerRecorder handle, ProfilerRecorderSample* outSamples, int outSamplesSize, bool reset)
		{
			return ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField(ref handle, outSamples, outSamplesSize, reset);
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_SharedRecorder;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(0)]
		public ulong handle;

		// Token: 0x040000C1 RID: 193
		private static readonly ProfilerRecorder.GetValueUnitType_InjectedDelegate GetValueUnitType_InjectedDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly ProfilerRecorder.GetValueDataType_InjectedDelegate GetValueDataType_InjectedDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly ProfilerRecorder.GetCurrentValue_InjectedDelegate GetCurrentValue_InjectedDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate GetCurrentValueAsDouble_InjectedDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate GetLastValueAsDouble_InjectedDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly ProfilerRecorder.GetWrapped_InjectedDelegate GetWrapped_InjectedDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly ProfilerRecorder.CopyTo_List_InjectedDelegate CopyTo_List_InjectedDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly ProfilerRecorder.CopyTo_Pointer_InjectedDelegate CopyTo_Pointer_InjectedDelegateField;

		// Token: 0x02000394 RID: 916
		[OriginalName("UnityEngine.CoreModule.dll", "", "ControlOptions")]
		public enum ControlOptions
		{
			// Token: 0x040029D3 RID: 10707
			Start,
			// Token: 0x040029D4 RID: 10708
			Stop,
			// Token: 0x040029D5 RID: 10709
			Reset,
			// Token: 0x040029D6 RID: 10710
			Release = 4,
			// Token: 0x040029D7 RID: 10711
			SetFilterToCurrentThread,
			// Token: 0x040029D8 RID: 10712
			SetToCollectFromAllThreads
		}

		// Token: 0x02000395 RID: 917
		[OriginalName("UnityEngine.CoreModule.dll", "", "CountOptions")]
		public enum CountOptions
		{
			// Token: 0x040029DA RID: 10714
			Count,
			// Token: 0x040029DB RID: 10715
			MaxCount
		}

		// Token: 0x02000396 RID: 918
		// (Invoke) Token: 0x06002FB8 RID: 12216
		private delegate ProfilerMarkerDataUnit GetValueUnitType_InjectedDelegate(IntPtr handle);

		// Token: 0x02000397 RID: 919
		// (Invoke) Token: 0x06002FBA RID: 12218
		private delegate Unity.Profiling.LowLevel.ProfilerMarkerDataType GetValueDataType_InjectedDelegate(IntPtr handle);

		// Token: 0x02000398 RID: 920
		// (Invoke) Token: 0x06002FBC RID: 12220
		private delegate long GetCurrentValue_InjectedDelegate(IntPtr handle);

		// Token: 0x02000399 RID: 921
		// (Invoke) Token: 0x06002FBE RID: 12222
		private delegate double GetCurrentValueAsDouble_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039A RID: 922
		// (Invoke) Token: 0x06002FC0 RID: 12224
		private delegate double GetLastValueAsDouble_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039B RID: 923
		// (Invoke) Token: 0x06002FC2 RID: 12226
		private delegate bool GetWrapped_InjectedDelegate(IntPtr handle);

		// Token: 0x0200039C RID: 924
		// (Invoke) Token: 0x06002FC4 RID: 12228
		private delegate void CopyTo_List_InjectedDelegate(IntPtr handle, IntPtr outSamples, bool reset);

		// Token: 0x0200039D RID: 925
		// (Invoke) Token: 0x06002FC6 RID: 12230
		private delegate int CopyTo_Pointer_InjectedDelegate(IntPtr handle, IntPtr outSamples, int outSamplesSize, bool reset);
	}
}
