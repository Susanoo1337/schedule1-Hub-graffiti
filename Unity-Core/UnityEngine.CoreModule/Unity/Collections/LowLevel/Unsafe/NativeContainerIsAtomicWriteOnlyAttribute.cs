using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004B RID: 75
	public sealed class NativeContainerIsAtomicWriteOnlyAttribute : Attribute
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0000345A File Offset: 0x0000165A
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerIsAtomicWriteOnlyAttribute()
		{
			Il2CppClassPointerStore<NativeContainerIsAtomicWriteOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerIsAtomicWriteOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerIsAtomicWriteOnlyAttribute>.NativeClassPtr);
			NativeContainerIsAtomicWriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerIsAtomicWriteOnlyAttribute>.NativeClassPtr, 100663532);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001F508 File Offset: 0x0001D708
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerIsAtomicWriteOnlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerIsAtomicWriteOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerIsAtomicWriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003493 File Offset: 0x00001693
		public NativeContainerIsAtomicWriteOnlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
