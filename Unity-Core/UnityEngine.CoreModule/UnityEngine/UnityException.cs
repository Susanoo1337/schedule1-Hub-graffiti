using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class UnityException : Exception
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x0006B380 File Offset: 0x00069580
		// Note: this type is marked as 'beforefieldinit'.
		static UnityException()
		{
			Il2CppClassPointerStore<UnityException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnityException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityException>.NativeClassPtr);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100665964);
			UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100665965);
			UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100665966);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0006B3EC File Offset: 0x000695EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260887, XrefRangeEnd = 1260893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006B428 File Offset: 0x00069628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1260897, RefRangeEnd = 1260901, XrefRangeStart = 1260893, XrefRangeEnd = 1260897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(string message) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0006B474 File Offset: 0x00069674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260901, XrefRangeEnd = 1260905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityException(SerializationInfo info, StreamingContext context) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		public UnityException(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040014F4 RID: 5364
		public const int Result = -2147467261;
	}
}
