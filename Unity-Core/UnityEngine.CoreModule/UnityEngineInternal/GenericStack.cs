using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;

namespace UnityEngineInternal
{
	// Token: 0x02000009 RID: 9
	public class GenericStack : Stack
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000217A File Offset: 0x0000037A
		// Note: this type is marked as 'beforefieldinit'.
		static GenericStack()
		{
			Il2CppClassPointerStore<GenericStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "GenericStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericStack>.NativeClassPtr);
			GenericStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStack>.NativeClassPtr, 100663304);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00018C14 File Offset: 0x00016E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1224720, RefRangeEnd = 1224721, XrefRangeStart = 1224719, XrefRangeEnd = 1224720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericStack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000021B3 File Offset: 0x000003B3
		public GenericStack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
