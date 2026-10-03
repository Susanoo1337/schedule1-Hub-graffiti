using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004C RID: 76
	public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
	{
		// Token: 0x06000290 RID: 656 RVA: 0x0000349C File Offset: 0x0000169C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsMinMaxWriteRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsMinMaxWriteRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr);
			NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr, 100663533);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001F544 File Offset: 0x0001D744
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsMinMaxWriteRestrictionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000034D5 File Offset: 0x000016D5
		public NativeContainerSupportsMinMaxWriteRestrictionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
