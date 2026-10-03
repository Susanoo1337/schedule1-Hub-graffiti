using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004A RID: 74
	public sealed class NativeContainerIsReadOnlyAttribute : Attribute
	{
		// Token: 0x0600028A RID: 650 RVA: 0x00003418 File Offset: 0x00001618
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerIsReadOnlyAttribute()
		{
			Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerIsReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr);
			NativeContainerIsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr, 100663531);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001F4CC File Offset: 0x0001D6CC
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerIsReadOnlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerIsReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00003451 File Offset: 0x00001651
		public NativeContainerIsReadOnlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
