using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000028 RID: 40
	public static class ProfilerUnsafeUtility : Il2CppSystem.Object
	{
		// Token: 0x06000136 RID: 310 RVA: 0x0001BC4C File Offset: 0x00019E4C
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerUnsafeUtility()
		{
			Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerUnsafeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663416);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663417);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663418);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663419);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663420);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663421);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663422);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663423);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663424);
			ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663425);
			ProfilerUnsafeUtility.CreateCategoryDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategoryDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory");
			ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Unsafe");
			ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe");
			ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe");
			ProfilerUnsafeUtility.GetMarkerDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetMarkerDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetMarker");
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata");
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe");
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata");
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata");
			ProfilerUnsafeUtility.CreateCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue");
			ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe");
			ProfilerUnsafeUtility.FlushCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlushCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue");
			ProfilerUnsafeUtility.CreateFlowDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateFlowDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow");
			ProfilerUnsafeUtility.FlowEventDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlowEventDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent");
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject");
			ProfilerUnsafeUtility.Internal_GetNameDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_GetNameDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName");
			ProfilerUnsafeUtility.get_TimestampDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.get_TimestampDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp");
			ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryColor_Injected");
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001BE54 File Offset: 0x0001A054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225294, XrefRangeEnd = 1225296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort CreateCategory__Unmanaged(byte* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225296, XrefRangeEnd = 1225298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref categoryId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0001BEEC File Offset: 0x0001A0EC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1225300, RefRangeEnd = 1225330, XrefRangeStart = 1225298, XrefRangeEnd = 1225300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001BF58 File Offset: 0x0001A158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225330, XrefRangeEnd = 1225332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = name;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metadataCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001BFCC File Offset: 0x0001A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225332, XrefRangeEnd = 1225334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, byte* name, int nameLen, byte type, byte unit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref markerPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001C044 File Offset: 0x0001A244
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1225336, RefRangeEnd = 1225361, XrefRangeStart = 1225334, XrefRangeEnd = 1225336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(IntPtr markerPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref markerPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001C078 File Offset: 0x0001A278
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 1225363, RefRangeEnd = 1225433, XrefRangeStart = 1225361, XrefRangeEnd = 1225363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample(IntPtr markerPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref markerPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225433, XrefRangeEnd = 1225435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, byte* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &counterPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref categoryId;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataUnit;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counterOptions;
			IntPtr intPtr;
			IntPtr result = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return result;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001C150 File Offset: 0x0001A350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225435, XrefRangeEnd = 1225444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = chars;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charsLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001C198 File Offset: 0x0001A398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225444, XrefRangeEnd = 1225446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref categoryId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000294E File Offset: 0x00000B4E
		public ProfilerUnsafeUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002957 File Offset: 0x00000B57
		public static ushort CreateCategory(string name, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategoryDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), colorIndex);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		public unsafe static ushort CreateCategory(char* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategory_Unsafe(name, nameLen, colorIndex);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000296A File Offset: 0x00000B6A
		public unsafe static ushort CreateCategory_Unsafe(char* name, int nameLen, ProfilerCategoryColor colorIndex)
		{
			return ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField(name, nameLen, colorIndex);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		public unsafe static ushort GetCategoryByName(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_Unsafe(name, nameLen);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002979 File Offset: 0x00000B79
		public unsafe static ushort GetCategoryByName_Unsafe(char* name, int nameLen)
		{
			return ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField(name, nameLen);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001C210 File Offset: 0x0001A410
		public static UnityEngine.Color32 GetCategoryColor(ProfilerCategoryColor colorIndex)
		{
			UnityEngine.Color32 result;
			ProfilerUnsafeUtility.GetCategoryColor_Injected(colorIndex, out result);
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0001C228 File Offset: 0x0001A428
		public unsafe static IntPtr CreateMarker(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_Unsafe(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002987 File Offset: 0x00000B87
		public unsafe static IntPtr CreateMarker_Unsafe(char* name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount)
		{
			return ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField(name, nameLen, categoryId, flags, metadataCount);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002999 File Offset: 0x00000B99
		public static IntPtr GetMarker(string name)
		{
			return ProfilerUnsafeUtility.GetMarkerDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000029AB File Offset: 0x00000BAB
		public static void SetMarkerMetadata(IntPtr markerPtr, int index, string name, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadataDelegateField(markerPtr, index, IL2CPP.ManagedStringToIl2Cpp(name), type, unit);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe static void SetMarkerMetadata(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_Unsafe(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000029D3 File Offset: 0x00000BD3
		public unsafe static void SetMarkerMetadata_Unsafe(IntPtr markerPtr, int index, char* name, int nameLen, byte type, byte unit)
		{
			ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField(markerPtr, index, name, nameLen, type, unit);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000029E7 File Offset: 0x00000BE7
		public unsafe static void BeginSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000029F6 File Offset: 0x00000BF6
		public unsafe static void SingleSampleWithMetadata(IntPtr markerPtr, int metadataCount, void* metadata)
		{
			ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField(markerPtr, metadataCount, metadata);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001C248 File Offset: 0x0001A448
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, string name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValueDelegateField(out counterPtr, IL2CPP.ManagedStringToIl2Cpp(name), categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001C270 File Offset: 0x0001A470
		public unsafe static void* CreateCounterValue(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_Unsafe(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001C298 File Offset: 0x0001A498
		public unsafe static void* CreateCounterValue_Unsafe(out IntPtr counterPtr, char* name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions)
		{
			return ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002A05 File Offset: 0x00000C05
		public unsafe static void FlushCounterValue(void* counterValuePtr)
		{
			ProfilerUnsafeUtility.FlushCounterValueDelegateField(counterValuePtr);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002A12 File Offset: 0x00000C12
		public static uint CreateFlow(ushort categoryId)
		{
			return ProfilerUnsafeUtility.CreateFlowDelegateField(categoryId);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002A1F File Offset: 0x00000C1F
		public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType)
		{
			ProfilerUnsafeUtility.FlowEventDelegateField(flowId, flowEventType);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002A2D File Offset: 0x00000C2D
		public static void Internal_BeginWithObject(IntPtr markerPtr, UnityEngine.Object contextUnityObject)
		{
			ProfilerUnsafeUtility.Internal_BeginWithObjectDelegateField(markerPtr, IL2CPP.Il2CppObjectBaseToPtr(contextUnityObject));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
		public static string Internal_GetName(IntPtr markerPtr)
		{
			IntPtr intPtr = ProfilerUnsafeUtility.Internal_GetNameDelegateField(markerPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002A40 File Offset: 0x00000C40
		public static long Timestamp
		{
			get
			{
				return ProfilerUnsafeUtility.get_TimestampDelegateField();
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002A4C File Offset: 0x00000C4C
		public static void GetCategoryColor_Injected(ProfilerCategoryColor colorIndex, out UnityEngine.Color32 ret)
		{
			ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField(colorIndex, out ret);
		}

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0;

		// Token: 0x04000118 RID: 280
		public const ushort CategoryRender = 0;

		// Token: 0x04000119 RID: 281
		public const ushort CategoryScripts = 1;

		// Token: 0x0400011A RID: 282
		public const ushort CategoryGUI = 4;

		// Token: 0x0400011B RID: 283
		public const ushort CategoryPhysics = 5;

		// Token: 0x0400011C RID: 284
		public const ushort CategoryAnimation = 6;

		// Token: 0x0400011D RID: 285
		public const ushort CategoryAi = 7;

		// Token: 0x0400011E RID: 286
		public const ushort CategoryAudio = 8;

		// Token: 0x0400011F RID: 287
		public const ushort CategoryVideo = 11;

		// Token: 0x04000120 RID: 288
		public const ushort CategoryParticles = 12;

		// Token: 0x04000121 RID: 289
		public const ushort CategoryLighting = 13;

		// Token: 0x04000122 RID: 290
		public const ushort CategoryLightning = 13;

		// Token: 0x04000123 RID: 291
		public const ushort CategoryNetwork = 14;

		// Token: 0x04000124 RID: 292
		public const ushort CategoryLoading = 15;

		// Token: 0x04000125 RID: 293
		public const ushort CategoryOther = 16;

		// Token: 0x04000126 RID: 294
		public const ushort CategoryVr = 22;

		// Token: 0x04000127 RID: 295
		public const ushort CategoryAllocation = 23;

		// Token: 0x04000128 RID: 296
		public const ushort CategoryInternal = 24;

		// Token: 0x04000129 RID: 297
		public const ushort CategoryFileIO = 25;

		// Token: 0x0400012A RID: 298
		public const ushort CategoryInput = 30;

		// Token: 0x0400012B RID: 299
		public const ushort CategoryVirtualTexturing = 31;

		// Token: 0x0400012C RID: 300
		public const ushort CategoryGPU = 32;

		// Token: 0x0400012D RID: 301
		public const ushort CategoryPhysics2D = 33;

		// Token: 0x0400012E RID: 302
		public const ushort CategoryAny = 65535;

		// Token: 0x0400012F RID: 303
		private static readonly ProfilerUnsafeUtility.CreateCategoryDelegate CreateCategoryDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate CreateCategory_UnsafeDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate GetCategoryByName_UnsafeDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate CreateMarker_UnsafeDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly ProfilerUnsafeUtility.GetMarkerDelegate GetMarkerDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadataDelegate SetMarkerMetadataDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate SetMarkerMetadata_UnsafeDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate BeginSampleWithMetadataDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate SingleSampleWithMetadataDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly ProfilerUnsafeUtility.CreateCounterValueDelegate CreateCounterValueDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate CreateCounterValue_UnsafeDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly ProfilerUnsafeUtility.FlushCounterValueDelegate FlushCounterValueDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly ProfilerUnsafeUtility.CreateFlowDelegate CreateFlowDelegateField;

		// Token: 0x0400013C RID: 316
		private static readonly ProfilerUnsafeUtility.FlowEventDelegate FlowEventDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly ProfilerUnsafeUtility.Internal_BeginWithObjectDelegate Internal_BeginWithObjectDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly ProfilerUnsafeUtility.Internal_GetNameDelegate Internal_GetNameDelegateField;

		// Token: 0x0400013F RID: 319
		private static readonly ProfilerUnsafeUtility.get_TimestampDelegate get_TimestampDelegateField;

		// Token: 0x04000140 RID: 320
		private static readonly ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate GetCategoryColor_InjectedDelegateField;

		// Token: 0x020003A1 RID: 929
		// (Invoke) Token: 0x06002FCE RID: 12238
		private delegate ushort CreateCategoryDelegate(IntPtr name, ProfilerCategoryColor colorIndex);

		// Token: 0x020003A2 RID: 930
		// (Invoke) Token: 0x06002FD0 RID: 12240
		private delegate ushort CreateCategory_UnsafeDelegate(IntPtr name, int nameLen, ProfilerCategoryColor colorIndex);

		// Token: 0x020003A3 RID: 931
		// (Invoke) Token: 0x06002FD2 RID: 12242
		private delegate ushort GetCategoryByName_UnsafeDelegate(IntPtr name, int nameLen);

		// Token: 0x020003A4 RID: 932
		// (Invoke) Token: 0x06002FD4 RID: 12244
		private delegate IntPtr CreateMarker_UnsafeDelegate(IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, int metadataCount);

		// Token: 0x020003A5 RID: 933
		// (Invoke) Token: 0x06002FD6 RID: 12246
		private delegate IntPtr GetMarkerDelegate(IntPtr name);

		// Token: 0x020003A6 RID: 934
		// (Invoke) Token: 0x06002FD8 RID: 12248
		private delegate void SetMarkerMetadataDelegate(IntPtr markerPtr, int index, IntPtr name, byte type, byte unit);

		// Token: 0x020003A7 RID: 935
		// (Invoke) Token: 0x06002FDA RID: 12250
		private delegate void SetMarkerMetadata_UnsafeDelegate(IntPtr markerPtr, int index, IntPtr name, int nameLen, byte type, byte unit);

		// Token: 0x020003A8 RID: 936
		// (Invoke) Token: 0x06002FDC RID: 12252
		private delegate void BeginSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020003A9 RID: 937
		// (Invoke) Token: 0x06002FDE RID: 12254
		private delegate void SingleSampleWithMetadataDelegate(IntPtr markerPtr, int metadataCount, IntPtr metadata);

		// Token: 0x020003AA RID: 938
		// (Invoke) Token: 0x06002FE0 RID: 12256
		private delegate IntPtr CreateCounterValueDelegate([Out] IntPtr counterPtr, IntPtr name, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020003AB RID: 939
		// (Invoke) Token: 0x06002FE2 RID: 12258
		private delegate IntPtr CreateCounterValue_UnsafeDelegate([Out] IntPtr counterPtr, IntPtr name, int nameLen, ushort categoryId, MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions);

		// Token: 0x020003AC RID: 940
		// (Invoke) Token: 0x06002FE4 RID: 12260
		private delegate void FlushCounterValueDelegate(IntPtr counterValuePtr);

		// Token: 0x020003AD RID: 941
		// (Invoke) Token: 0x06002FE6 RID: 12262
		private delegate uint CreateFlowDelegate(ushort categoryId);

		// Token: 0x020003AE RID: 942
		// (Invoke) Token: 0x06002FE8 RID: 12264
		private delegate void FlowEventDelegate(uint flowId, ProfilerFlowEventType flowEventType);

		// Token: 0x020003AF RID: 943
		// (Invoke) Token: 0x06002FEA RID: 12266
		private delegate void Internal_BeginWithObjectDelegate(IntPtr markerPtr, IntPtr contextUnityObject);

		// Token: 0x020003B0 RID: 944
		// (Invoke) Token: 0x06002FEC RID: 12268
		private delegate IntPtr Internal_GetNameDelegate(IntPtr markerPtr);

		// Token: 0x020003B1 RID: 945
		// (Invoke) Token: 0x06002FEE RID: 12270
		private delegate long get_TimestampDelegate();

		// Token: 0x020003B2 RID: 946
		// (Invoke) Token: 0x06002FF0 RID: 12272
		private delegate void GetCategoryColor_InjectedDelegate(ProfilerCategoryColor colorIndex, [Out] IntPtr ret);
	}
}
