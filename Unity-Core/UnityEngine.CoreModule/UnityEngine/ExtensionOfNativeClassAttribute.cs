using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000139 RID: 313
	public sealed class ExtensionOfNativeClassAttribute : Attribute
	{
		// Token: 0x0600183E RID: 6206 RVA: 0x0000C0E0 File Offset: 0x0000A2E0
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionOfNativeClassAttribute()
		{
			Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExtensionOfNativeClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr);
			ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr, 100665843);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00067E90 File Offset: 0x00066090
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionOfNativeClassAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0000C119 File Offset: 0x0000A319
		public ExtensionOfNativeClassAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
