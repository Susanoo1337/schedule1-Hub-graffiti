using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine
{
	// Token: 0x0200014D RID: 333
	[Serializable]
	public class MissingReferenceException : Exception
	{
		// Token: 0x06001924 RID: 6436 RVA: 0x0006B4D8 File Offset: 0x000696D8
		// Note: this type is marked as 'beforefieldinit'.
		static MissingReferenceException()
		{
			Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MissingReferenceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100665967);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100665968);
			MissingReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr, 100665969);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0006B544 File Offset: 0x00069744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260905, XrefRangeEnd = 1260911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0006B580 File Offset: 0x00069780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1260915, RefRangeEnd = 1260916, XrefRangeStart = 1260911, XrefRangeEnd = 1260915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException(string message) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0006B5CC File Offset: 0x000697CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260916, XrefRangeEnd = 1260920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingReferenceException(SerializationInfo info, StreamingContext context) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0000C4FD File Offset: 0x0000A6FD
		public MissingReferenceException(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040014F8 RID: 5368
		public const int Result = -2147467261;
	}
}
