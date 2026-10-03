using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000281 RID: 641
	public class AssertionException : Exception
	{
		// Token: 0x06002C0C RID: 11276 RVA: 0x000AAAB0 File Offset: 0x000A8CB0
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionException()
		{
			Il2CppClassPointerStore<AssertionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionException>.NativeClassPtr);
			AssertionException.NativeFieldInfoPtr_m_UserMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, "m_UserMessage");
			AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100668010);
			AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100668011);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x000AAB1C File Offset: 0x000A8D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294788, XrefRangeEnd = 1294793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssertionException(string message, string userMessage) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssertionException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000AAB7C File Offset: 0x000A8D7C
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294793, XrefRangeEnd = 1294797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0001338F File Offset: 0x0001158F
		public AssertionException(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002C10 RID: 11280 RVA: 0x000AABC0 File Offset: 0x000A8DC0
		// (set) Token: 0x06002C11 RID: 11281 RVA: 0x00013398 File Offset: 0x00011598
		public unsafe string m_UserMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeFieldInfoPtr_m_UserMessage;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
