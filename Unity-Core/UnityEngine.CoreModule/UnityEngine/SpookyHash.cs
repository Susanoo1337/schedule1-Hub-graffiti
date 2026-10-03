using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E8 RID: 232
	public static class SpookyHash : Object
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x00053EE4 File Offset: 0x000520E4
		// Note: this type is marked as 'beforefieldinit'.
		static SpookyHash()
		{
			Il2CppClassPointerStore<SpookyHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpookyHash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr);
			SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665154);
			SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665155);
			SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665156);
			SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665157);
			SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665158);
			SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665159);
			SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665160);
			SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665161);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00053FB4 File Offset: 0x000521B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241884, RefRangeEnd = 1241887, XrefRangeStart = 1241875, XrefRangeEnd = 1241884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = message;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00054010 File Offset: 0x00052210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241887, XrefRangeEnd = 1241890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h7;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h8;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h9;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h10;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000540F8 File Offset: 0x000522F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1241890, RefRangeEnd = 1241896, XrefRangeStart = 1241890, XrefRangeEnd = 1241890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &h0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h4;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h5;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h6;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h7;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h8;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h9;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h10;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000541D0 File Offset: 0x000523D0
		[CallerCount(0)]
		public unsafe static void Rot64(ref ulong x, int k)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00054210 File Offset: 0x00052410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241905, RefRangeEnd = 1241906, XrefRangeStart = 1241896, XrefRangeEnd = 1241905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = message;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0005426C File Offset: 0x0005246C
		[CallerCount(0)]
		public unsafe static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &h0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000542C8 File Offset: 0x000524C8
		[CallerCount(0)]
		public unsafe static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &h0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x00054324 File Offset: 0x00052524
		[CallerCount(0)]
		public unsafe static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = data;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s7;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s8;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s9;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s10;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0000A65D File Offset: 0x0000885D
		public SpookyHash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x04000F3C RID: 3900
		public const int k_NumVars = 12;

		// Token: 0x04000F3D RID: 3901
		public const int k_BlockSize = 96;

		// Token: 0x04000F3E RID: 3902
		public const int k_BufferSize = 192;

		// Token: 0x04000F3F RID: 3903
		public const ulong k_DeadBeefConst = 16045690984833335023UL;

		// Token: 0x0200086F RID: 2159
		[StructLayout(2)]
		public struct U
		{
			// Token: 0x0600396F RID: 14703 RVA: 0x000B1234 File Offset: 0x000AF434
			// Note: this type is marked as 'beforefieldinit'.
			static U()
			{
				Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, "U");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr);
				SpookyHash.U.NativeFieldInfoPtr_p8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p8");
				SpookyHash.U.NativeFieldInfoPtr_p32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p32");
				SpookyHash.U.NativeFieldInfoPtr_p64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p64");
				SpookyHash.U.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "i");
				SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, 100665162);
			}

			// Token: 0x06003970 RID: 14704 RVA: 0x000B12C4 File Offset: 0x000AF4C4
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe U(ushort* p8)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = p8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003971 RID: 14705 RVA: 0x00015D3F File Offset: 0x00013F3F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, ref this));
			}

			// Token: 0x04002AD5 RID: 10965
			private static readonly IntPtr NativeFieldInfoPtr_p8;

			// Token: 0x04002AD6 RID: 10966
			private static readonly IntPtr NativeFieldInfoPtr_p32;

			// Token: 0x04002AD7 RID: 10967
			private static readonly IntPtr NativeFieldInfoPtr_p64;

			// Token: 0x04002AD8 RID: 10968
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04002AD9 RID: 10969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0;

			// Token: 0x04002ADA RID: 10970
			[FieldOffset(0)]
			public IntPtr p8;

			// Token: 0x04002ADB RID: 10971
			[FieldOffset(0)]
			public IntPtr p32;

			// Token: 0x04002ADC RID: 10972
			[FieldOffset(0)]
			public IntPtr p64;

			// Token: 0x04002ADD RID: 10973
			[FieldOffset(0)]
			public ulong i;
		}
	}
}
