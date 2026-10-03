using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000049 RID: 73
	public sealed class NativeContainerAttribute : Attribute
	{
		// Token: 0x06000287 RID: 647 RVA: 0x000033D6 File Offset: 0x000015D6
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerAttribute()
		{
			Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr);
			NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr, 100663530);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001F490 File Offset: 0x0001D690
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000340F File Offset: 0x0000160F
		public NativeContainerAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
