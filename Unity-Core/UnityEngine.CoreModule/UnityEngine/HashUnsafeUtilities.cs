using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E7 RID: 231
	public static class HashUnsafeUtilities : Object
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x00053DE4 File Offset: 0x00051FE4
		// Note: this type is marked as 'beforefieldinit'.
		static HashUnsafeUtilities()
		{
			Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUnsafeUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr);
			HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665152);
			HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665153);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00053E3C File Offset: 0x0005203C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241873, XrefRangeEnd = 1241874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00053E98 File Offset: 0x00052098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241874, XrefRangeEnd = 1241875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0000A654 File Offset: 0x00008854
		public HashUnsafeUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0;
	}
}
