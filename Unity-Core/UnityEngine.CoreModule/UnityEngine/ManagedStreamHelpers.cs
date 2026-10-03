using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine
{
	// Token: 0x02000141 RID: 321
	public static class ManagedStreamHelpers : Object
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x00069B58 File Offset: 0x00067D58
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedStreamHelpers()
		{
			Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ManagedStreamHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr);
			ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100665901);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100665902);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100665903);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100665904);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00069BD8 File Offset: 0x00067DD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1259558, RefRangeEnd = 1259561, XrefRangeStart = 1259558, XrefRangeEnd = 1259558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateLoadFromStream(Stream stream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00069C10 File Offset: 0x00067E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259561, XrefRangeEnd = 1259564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamRead(Il2CppStructArray<byte> buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00069C84 File Offset: 0x00067E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259564, XrefRangeEnd = 1259567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00069CE4 File Offset: 0x00067EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259567, XrefRangeEnd = 1259570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0000C376 File Offset: 0x0000A576
		public ManagedStreamHelpers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0;
	}
}
