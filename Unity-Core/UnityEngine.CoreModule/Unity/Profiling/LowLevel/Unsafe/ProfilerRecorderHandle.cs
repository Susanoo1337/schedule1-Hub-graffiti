using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000026 RID: 38
	[StructLayout(2)]
	public struct ProfilerRecorderHandle
	{
		// Token: 0x06000122 RID: 290 RVA: 0x0001B820 File Offset: 0x00019A20
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerRecorderHandle()
		{
			Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerRecorderHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr);
			ProfilerRecorderHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, "handle");
			ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663409);
			ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663410);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663411);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663412);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663413);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663414);
			ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663415);
			ProfilerRecorderHandle.GetAvailableDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetAvailableDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetAvailable");
			ProfilerRecorderHandle.GetByName_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Injected");
			ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Unsafe_Injected");
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001B920 File Offset: 0x00019B20
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfilerRecorderHandle(ulong handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0001B954 File Offset: 0x00019B54
		public unsafe bool Valid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1225280, RefRangeEnd = 1225282, XrefRangeStart = 1225280, XrefRangeEnd = 1225280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0001B984 File Offset: 0x00019B84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1225284, RefRangeEnd = 1225286, XrefRangeStart = 1225282, XrefRangeEnd = 1225284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225286, XrefRangeEnd = 1225288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderHandle GetByName__Unmanaged(ProfilerCategory category, byte* name, int nameLen)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001BA1C File Offset: 0x00019C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225288, XrefRangeEnd = 1225290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProfilerRecorderDescription GetDescriptionInternal(ProfilerRecorderHandle handle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001BA5C File Offset: 0x00019C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225290, XrefRangeEnd = 1225292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetByName__Unmanaged_Injected(ref ProfilerCategory category, byte* name, int nameLen, out ProfilerRecorderHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &category;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = name;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nameLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225292, XrefRangeEnd = 1225294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetDescriptionInternal_Injected(ref ProfilerRecorderHandle handle, out ProfilerRecorderDescription ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &handle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000028E1 File Offset: 0x00000AE1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		public static ProfilerRecorderHandle Get(ProfilerMarker marker)
		{
			return new ProfilerRecorderHandle((ulong)marker.Handle.ToInt64());
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001BB20 File Offset: 0x00019D20
		public static ProfilerRecorderHandle Get(ProfilerCategory category, string statName)
		{
			bool flag = String.IsNullOrEmpty(statName);
			if (flag)
			{
				throw new ArgumentException("String must be not null or empty", "statName");
			}
			return ProfilerRecorderHandle.GetByName(category, statName);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000028F3 File Offset: 0x00000AF3
		public static void GetAvailable(List<ProfilerRecorderHandle> outRecorderHandleList)
		{
			ProfilerRecorderHandle.GetAvailableDelegateField(IL2CPP.Il2CppObjectBaseToPtr(outRecorderHandleList));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001BB54 File Offset: 0x00019D54
		public static ProfilerRecorderHandle GetByName(ProfilerCategory category, string name)
		{
			ProfilerRecorderHandle result;
			ProfilerRecorderHandle.GetByName_Injected(ref category, name, out result);
			return result;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001BB6C File Offset: 0x00019D6C
		public unsafe static ProfilerRecorderHandle GetByName(ProfilerCategory category, char* name, int nameLen)
		{
			return ProfilerRecorderHandle.GetByName_Unsafe(category, name, nameLen);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001BB88 File Offset: 0x00019D88
		public unsafe static ProfilerRecorderHandle GetByName_Unsafe(ProfilerCategory category, char* name, int nameLen)
		{
			ProfilerRecorderHandle result;
			ProfilerRecorderHandle.GetByName_Unsafe_Injected(ref category, name, nameLen, out result);
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002905 File Offset: 0x00000B05
		public static void GetByName_Injected(ref ProfilerCategory category, string name, out ProfilerRecorderHandle ret)
		{
			ProfilerRecorderHandle.GetByName_InjectedDelegateField(ref category, IL2CPP.ManagedStringToIl2Cpp(name), out ret);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002919 File Offset: 0x00000B19
		public unsafe static void GetByName_Unsafe_Injected(ref ProfilerCategory category, char* name, int nameLen, out ProfilerRecorderHandle ret)
		{
			ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField(ref category, name, nameLen, out ret);
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0;

		// Token: 0x040000FD RID: 253
		[FieldOffset(0)]
		public readonly ulong handle;

		// Token: 0x040000FE RID: 254
		public const ulong k_InvalidHandle = 18446744073709551615UL;

		// Token: 0x040000FF RID: 255
		private static readonly ProfilerRecorderHandle.GetAvailableDelegate GetAvailableDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly ProfilerRecorderHandle.GetByName_InjectedDelegate GetByName_InjectedDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate GetByName_Unsafe_InjectedDelegateField;

		// Token: 0x0200039E RID: 926
		// (Invoke) Token: 0x06002FC8 RID: 12232
		private delegate void GetAvailableDelegate(IntPtr outRecorderHandleList);

		// Token: 0x0200039F RID: 927
		// (Invoke) Token: 0x06002FCA RID: 12234
		private delegate void GetByName_InjectedDelegate(IntPtr category, IntPtr name, [Out] IntPtr ret);

		// Token: 0x020003A0 RID: 928
		// (Invoke) Token: 0x06002FCC RID: 12236
		private delegate void GetByName_Unsafe_InjectedDelegate(IntPtr category, IntPtr name, int nameLen, [Out] IntPtr ret);
	}
}
