using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004D RID: 77
	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x06000293 RID: 659 RVA: 0x000034DE File Offset: 0x000016DE
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr);
			NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr, 100663534);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001F580 File Offset: 0x0001D780
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeallocateOnJobCompletionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00003517 File Offset: 0x00001717
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
