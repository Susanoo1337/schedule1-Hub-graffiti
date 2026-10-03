using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000E6 RID: 230
	public static class HashUtilities : Object
	{
		// Token: 0x060012DB RID: 4827 RVA: 0x0000A605 File Offset: 0x00008805
		// Note: this type is marked as 'beforefieldinit'.
		static HashUtilities()
		{
			Il2CppClassPointerStore<HashUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr);
			HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr, 100665151);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00053CC4 File Offset: 0x00051EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241872, RefRangeEnd = 1241873, XrefRangeStart = 1241871, XrefRangeEnd = 1241872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendHash(ref Hash128 inHash, ref Hash128 outHash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &inHash;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000A63E File Offset: 0x0000883E
		public HashUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00053D04 File Offset: 0x00051F04
		public unsafe static void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* hash2 = ptr;
				int* ptr2 = stackalloc int[(UIntPtr)64];
				for (int i = 0; i < 16; i++)
				{
					ptr2[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr2, 64UL, hash2);
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00053D60 File Offset: 0x00051F60
		public unsafe static void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash)
		{
			fixed (Hash128* ptr = &hash)
			{
				Hash128* hash2 = ptr;
				int* ptr2 = stackalloc int[(UIntPtr)12];
				for (int i = 0; i < 3; i++)
				{
					ptr2[i] = (int)(value[i] * 1000f + 0.5f);
				}
				HashUnsafeUtilities.ComputeHash128((void*)ptr2, 12UL, hash2);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00053DB8 File Offset: 0x00051FB8
		public unsafe static void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct
		{
			void* data = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<T>(ref value);
			ulong dataSize = (ulong)((long)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
			Hash128* hash2 = (Hash128*)Unity.Collections.LowLevel.Unsafe.UnsafeUtility.AddressOf<Hash128>(ref hash);
			HashUnsafeUtilities.ComputeHash128(data, dataSize, hash2);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0000A647 File Offset: 0x00008847
		public static void ComputeHash128(Il2CppStructArray<byte> value, ref Hash128 hash)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0;
	}
}
