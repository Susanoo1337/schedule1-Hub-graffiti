using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000282 RID: 642
	public class AssertionMessageUtil : Object
	{
		// Token: 0x06002C12 RID: 11282 RVA: 0x000AABE8 File Offset: 0x000A8DE8
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionMessageUtil()
		{
			Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionMessageUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668012);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668013);
			AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668014);
			AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668015);
			AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668016);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000AAC7C File Offset: 0x000A8E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294797, XrefRangeEnd = 1294816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000AACB8 File Offset: 0x000A8EB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1294861, RefRangeEnd = 1294866, XrefRangeStart = 1294816, XrefRangeEnd = 1294861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage, string expected)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000AAD08 File Offset: 0x000A8F08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1294904, RefRangeEnd = 1294906, XrefRangeStart = 1294866, XrefRangeEnd = 1294904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEqualityMessage(Object actual, Object expected, bool expectEqual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(actual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectEqual;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x000AAD64 File Offset: 0x000A8F64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1294933, RefRangeEnd = 1294939, XrefRangeStart = 1294906, XrefRangeEnd = 1294933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NullFailureMessage(Object value, bool expectNull)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x000AADB0 File Offset: 0x000A8FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294939, XrefRangeEnd = 1294948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BooleanFailureMessage(bool expected)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref expected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x000133B7 File Offset: 0x000115B7
		public AssertionMessageUtil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0;

		// Token: 0x04002650 RID: 9808
		public const string k_Expected = "Expected:";

		// Token: 0x04002651 RID: 9809
		public const string k_AssertionFailed = "Assertion failure.";
	}
}
